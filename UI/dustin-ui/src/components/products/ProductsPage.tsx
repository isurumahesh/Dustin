import React, { useEffect, useState } from "react";
import Typography from "@mui/material/Typography";
import TextField from "@mui/material/TextField";
import Box from "@mui/material/Box";
import { Button, CircularProgress, Pagination, SnackbarCloseReason } from "@mui/material";
import AddEditProductModal from "./AddEditProductModal";
import { productsApi } from "../../api/productsApi";
import { ViewProductItemData, SelectedSubFeatures } from "../../types/productTypes";
import ProductList from "./ProductList";
import { getAllProductItems, getProductItems, initializeProductFormData, mapCreateProduct, mapUpdateProduct } from "../../utils/productUtils";
import SnackBarModal from "../common/SnackBar";


const ProductsPage = () => {
    const [searchQuery, setSearchQuery] = useState<string>("");
    const [isModalOpen, setModalOpen] = useState<boolean>(false);
    const [products, setProducts] = useState<ViewProductItemData[]>([]);
    const [filteredProducts, setFilteredProducts] = useState<ViewProductItemData[]>([]);
    const [modalData, setModalData] = useState<ViewProductItemData>(initializeProductFormData());

    const [snackBarOpen, setSnackBarOpen] = useState(false);
    const [snackBarMessage, setSnackBarMessage] = useState("");
    const [modalTitle, setModalTitle] = useState("");
    const [isProductsLoading, setIsProductsLoading] = useState(false);

    const [currentPage, setCurrentPage] = useState(1);
    const itemsPerPage = 10;

    const handleSnackBarClose = (
        event: React.SyntheticEvent | Event,
        reason?: SnackbarCloseReason,
    ) => {
        if (reason === 'clickaway') {
            return;
        }

        setSnackBarOpen(false);
    };

    const handleOpenModal = () => {
        setModalOpen(true);
        setModalData(initializeProductFormData())
        setModalTitle("Add Product")
    }

    const handleCloseModal = () => setModalOpen(false);

    const handleSnackBar = (isOpen: boolean, message: string) => {
        setSnackBarOpen(isOpen);
        setSnackBarMessage(message)
    }

    const handleEdit = (viewProductItemData: ViewProductItemData) => {
        setModalData({ ...viewProductItemData })
        setModalOpen(true)
        setModalTitle("Update Product")
    }

    const handleDelete = (id: string) => {
        productsApi.deleteProduct(id).then(res => {

            setFilteredProducts(products.filter((product) => product.productId !== id));
            handleSnackBar(true, "Product is deleted successfully");

        }).catch(res => {
            handleSnackBar(true, "Error deleting product");
        })
    }

    const handleInputChange = (search: string) => {
        setSearchQuery(search)
        const filtered = products.filter(
            (item) =>
                item.productId.toLowerCase().includes(search) ||
                item.name.toLowerCase().includes(search) ||
                item.description.toLowerCase().includes(search) ||
                item.brand.toLowerCase().includes(search) ||
                item.categoryName.toLowerCase().includes(search) ||
                item.subCategoryValue.toLowerCase().includes(search) ||
                item.stock.includes(search) ||
                item.price.includes(search)
        );

        setFilteredProducts(filtered);
        setCurrentPage(1);

    };

    useEffect(() => {
        setIsProductsLoading(true)

        productsApi.getProducts().then(res => {
            let allItems = getAllProductItems(res);
            setProducts(allItems)
            setFilteredProducts(allItems);
            handleSnackBar(true, "Products are loaded successfully");

        }).catch(res => {
            handleSnackBar(true, "Error loading product");
        }).finally(() => {
            setIsProductsLoading(false)
        })

    }, []);

    const saveProduct = async (formData: ViewProductItemData, selectedSubfeatures: SelectedSubFeatures[]) => {

        const createProduct = mapCreateProduct(formData, selectedSubfeatures);
        setIsProductsLoading(true)
        if (!formData.productId) {
            productsApi.saveProduct(createProduct).then(res => {
                return res;
            }).then(res => {
                productsApi.getProduct(res.id).then(p => {
                    handleCloseModal()
                    let items = getProductItems(p);
                    setFilteredProducts([...filteredProducts, ...items])
                    handleSnackBar(true, "Product is saved successfully");
                    setModalData(initializeProductFormData())
                })

            }).catch(res => {
                handleCloseModal()
                handleSnackBar(true, "Error saving product");
            }).finally(() => {
                setIsProductsLoading(false)
            })
        }
        else {
            const updateProduct = mapUpdateProduct(formData, selectedSubfeatures);
            productsApi.updateProduct(updateProduct).then(res => {
                handleCloseModal()
                setModalData(initializeProductFormData())
                formData.selectedSubFeatures = selectedSubfeatures;
                setFilteredProducts((prevProducts) =>
                    prevProducts.map((product) =>
                        product.productId === updateProduct.id ? formData : product
                    )
                );
                handleSnackBar(true, "Product is updated successfully");
            }).catch(res => {
                handleCloseModal()
                handleSnackBar(true, "Error updating product");
            }).finally(() => {
                setIsProductsLoading(false)
            })
        }
    }

    const handlePageChange = (_event: React.ChangeEvent<unknown>, page: number) => {
        setCurrentPage(page);
    };

    const getPaginatedProducts = () => {
        const paginatedProducts = filteredProducts.slice(
            (currentPage - 1) * itemsPerPage,
            currentPage * itemsPerPage
        );
        return paginatedProducts;
    }
 
    return (
        <>
            {isProductsLoading ? <Box
                sx={{
                    position: 'fixed',
                    top: '50%',
                    left: '50%',
                    transform: 'translate(-50%, -50%)',
                    zIndex: 9999,
                }}
            >
                <CircularProgress />
            </Box> :
                <Box sx={{ padding: 2 }}>

                    {isModalOpen && <AddEditProductModal
                        handleCloseModal={handleCloseModal}
                        isModalOpen={isModalOpen}
                        productModalData={modalData}
                        modalTitle={modalTitle}
                        saveProduct={saveProduct} />}

                    <Typography variant="h4" gutterBottom>
                        Product List
                    </Typography>
                    <Box sx={{ marginBottom: 2 }}>
                        <TextField
                            label="Search Products"
                            variant="outlined"
                            sx={{ width: '25%' }}
                            value={searchQuery}
                            onChange={(e) => handleInputChange(e.target.value)}
                        />
                    </Box>

                    <Box sx={{ display: "flex", justifyContent: "flex-end", marginBottom: 2 }}>
                        <Button variant="contained" onClick={handleOpenModal} color="primary">
                            Add Product
                        </Button>
                    </Box>

                    <ProductList products={getPaginatedProducts()} searchQuery={searchQuery} handleEdit={handleEdit} handleDelete={handleDelete}></ProductList>

                    <Pagination
                        count={Math.ceil(filteredProducts.length / itemsPerPage)}
                        page={currentPage}
                        onChange={handlePageChange}
                        color="primary"
                        sx={{ marginTop: 3, display: "flex", justifyContent: "center" }}
                    />
                    <SnackBarModal snackBarOpen={snackBarOpen} message={snackBarMessage} handleSnackBarClose={handleSnackBarClose} />

                </Box>
            }

        </>

    );
};

export default ProductsPage;
