import React, { useState } from "react";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import { IconButton } from "@mui/material";
import { ViewProductItemData } from "../../types/productTypes";
import EditIcon from "@mui/icons-material/Edit";
import DeleteIcon from "@mui/icons-material/Delete";
import DeleteConfirmationModal from "./DeleteConfirmationModal";


type Props = {
    products: ViewProductItemData[],
    searchQuery:string,
    handleEdit: Function,
    handleDelete: Function
}

const ProductList = ({ products, searchQuery, handleEdit, handleDelete }: Props) => {

    const [deleteModalOpen, setDeleteModalOpen] = useState(false);
    const [productId, setProductId] = useState<string>("");

    const handleDeleteModalClose = () => setDeleteModalOpen(false);

    const handleDeleteConfrim = () => {
        if (productId) {
            handleDelete(productId);
        }
        setDeleteModalOpen(false);
    };

    const deleteProductItem = (id: string) => {
        setDeleteModalOpen(true)
        setProductId(id)
    }

    const highlightText = (text:string) => {
        if (!searchQuery) return text;
      
        const parts = text.split(new RegExp(`(${searchQuery})`, "gi"));
        return parts.map((part, index) =>
          part.toLowerCase() === searchQuery.toLowerCase() ? (
            <span key={index} style={{ backgroundColor: "yellow" }}>
              {part}
            </span>
          ) : (
            part
          )
        );
      };
      

    return (
        <>
            <DeleteConfirmationModal deleteModalOpen={deleteModalOpen} handleDeleteConfrim={handleDeleteConfrim} handleDeleteModalClose={handleDeleteModalClose}/>

            <TableContainer component={Paper}>
                <Table>
                    <TableHead>
                        <TableRow>
                            <TableCell><strong>ID</strong></TableCell>
                            <TableCell><strong>Name</strong></TableCell>
                            <TableCell><strong>Description</strong></TableCell>
                            <TableCell><strong>Brand</strong></TableCell>
                            <TableCell><strong>Category</strong></TableCell>
                            <TableCell><strong>SubCategory</strong></TableCell>
                            <TableCell><strong>Sku</strong></TableCell>
                            <TableCell><strong>Stock</strong></TableCell>
                            <TableCell align="right"><strong>Price (€)</strong></TableCell>
                            <TableCell><strong>Features</strong></TableCell>
                            <TableCell></TableCell>
                        </TableRow>
                    </TableHead>
                    <TableBody>
                        {products && products.map((product) => (
                            <TableRow key={product.productItemId}>
                                <TableCell>{product.productId}</TableCell>
                                <TableCell>{highlightText(product.name)}</TableCell>
                                <TableCell>{highlightText(product.description)}</TableCell>
                                <TableCell>{product.brand}</TableCell>
                                <TableCell>{product.categoryName}</TableCell>
                                <TableCell>{product.subCategoryValue}</TableCell>
                                <TableCell>{product.sku}</TableCell>
                                <TableCell>{product.stock}</TableCell>
                                <TableCell>{product.price}</TableCell>
                                <TableCell>{product.selectedSubFeatures && product.selectedSubFeatures.map(item => (<li key={item.id}>{item.value}</li>))}</TableCell>
                                <TableCell>
                                    <IconButton onClick={() => handleEdit(product)}>
                                        <EditIcon />
                                    </IconButton>
                                    <IconButton onClick={() => deleteProductItem(product.productId)}>
                                        <DeleteIcon />
                                    </IconButton>
                                </TableCell>
                            </TableRow>
                        ))}
                    </TableBody>
                </Table>
            </TableContainer>
        </>
    );
};

export default ProductList;
