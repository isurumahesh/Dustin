import React, { useCallback, useEffect, useState } from "react";
import {
    Box,
    Modal,
    Typography,
    TextField,
    Button,
    Select,
    MenuItem,
    Checkbox,
    FormControlLabel,
    FormGroup,
    SelectChangeEvent,
} from "@mui/material";
import { Brand, Category, Feature, SelectedSubFeatures, SubCategory, ViewProductItemData } from "../../types/productTypes";
import { productsApi } from "../../api/productsApi";

type Props = {
    handleCloseModal: Function
    isModalOpen: boolean
    productModalData: ViewProductItemData
    modalTitle: string
    saveProduct: Function
};

const AddEditProductModal = (props: Props) => {

    const [categories, setCategories] = useState<Category[]>([])
    const [subCategories, setSubCategories] = useState<SubCategory[] | undefined>([])
    const [features, setFeatures] = useState<Feature[]>([])
    const [mappedFeatures, setMappedFeatures] = useState<Feature[]>([])
    const [brands, setBrands] = useState<Brand[]>([])
    const [formData, setFormData] = useState<ViewProductItemData>(props.productModalData);
    const [errors, setErrors] = useState<any>({});

    const handleInputChange = (
        e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement | { name?: string; value: unknown }>
    ) => {
        const { name, value } = e.target;
        setFormData({ ...formData, [name!]: value });

        if (Object.keys(errors) && Object.keys(errors).includes(name!)) {
            setErrors((prevErrors: any) => ({ ...prevErrors, [name!]: undefined }));
        }

    };

    const handleSelectChange = (e: SelectChangeEvent) => {
        const { name, value } = e.target;
        setFormData({ ...formData, [name!]: value });

        if (name === "categoryId") {
            const subCategories = categories.find(a => a.id === value)?.subCategories;
            setSubCategories(subCategories ? [...subCategories] : []);
        }
        if (Object.keys(errors) && Object.keys(errors).includes(name!)) {
            setErrors((prevErrors: any) => ({ ...prevErrors, [name!]: undefined }));
        }

    };

    const mapSubFeatures = useCallback((features: Feature[]) => {
        let selectedSubFeatures = formData.selectedSubFeatures;
        let mappedFeatures: Feature[] = features.map((feature: Feature) => ({
            id: feature.id,
            name: feature.name,
            subFeatures: feature.subFeatures?.map((subFeature) => ({
                value: subFeature.value,
                id: subFeature.id,
                featureId: feature.id,
                checked: selectedSubFeatures && selectedSubFeatures.findIndex(a => a.id === subFeature.id) >= 0 ? true : false
            })),
        }));

        setMappedFeatures(mappedFeatures)
    }, [formData.selectedSubFeatures])

    useEffect(() => {
        mapSubFeatures(features)
    }, [props.productModalData.productId, mapSubFeatures, features])

    useEffect(() => {
        setFormData(props.productModalData);
        filterSubCategories(props.productModalData.categoryId, categories)

    }, [props.productModalData, categories])

    const handleFeatureChange = (featureId: string, subFeatureId: string) => {
        setMappedFeatures((prevFeatures) =>
            prevFeatures.map((feature) =>
                feature.id === featureId
                    ? {
                        ...feature,
                        subFeatures: feature.subFeatures?.map((subFeature) =>
                            subFeature.id === subFeatureId
                                ? { ...subFeature, checked: !subFeature.checked }
                                : { ...subFeature, checked: false }
                        ),
                    }
                    : feature
            )
        );
    };


    const validateForm = () => {
        const newErrors: any = {};
        if (!formData.name) { newErrors.name = "Name is required."; }
        if (!formData.description) { newErrors.description = "Description is required."; }
        if (!formData.sku) { newErrors.sku = "Sku is required."; }
        if (!formData.stock) { newErrors.stock = "Stock is required."; }
        if (!formData.price) { newErrors.price = "Price is required."; }
        if (!formData.brandId) { newErrors.brandId = "Brand is required."; }
        if (!formData.categoryId) { newErrors.categoryId = "Category is required."; }
        if (!formData.subCategoryId) { newErrors.subCategoryId = "SubCategory is required."; }

        if (formData.price && Number(formData.price) < 0) { newErrors.price = "Price should be greater than or equal to zero"; }
        if (formData.stock && Number(formData.stock) < 0) { newErrors.stock = "Stock should be greater than or equal to zero"; }

        return newErrors;
    };

    const saveProduct = () => {

        const validationErrors = validateForm();

        if (Object.keys(validationErrors).length !== 0) {
            setErrors({ ...validationErrors })
            return;
        }

        let selectedSubfeatures: SelectedSubFeatures[] = [];

        mappedFeatures.forEach(element => {
            const filtered = element.subFeatures?.filter(a => a.checked).map(a => ({ id: a.id, value: a.value }))
            if (filtered)
                selectedSubfeatures = [...selectedSubfeatures, ...filtered]

        });

        props.saveProduct(formData, selectedSubfeatures)
        setErrors({})

    }

    const filterSubCategories = (catergoryId: string, categories: Category[]) => {
        const subCategories = categories.find(a => a.id === catergoryId)?.subCategories;
        setSubCategories(subCategories ? [...subCategories] : []);
    }

    useEffect(() => {
        productsApi.getCategories().then(res => {
            setCategories(res)
        })

    }, []);

    useEffect(() => {
        productsApi.getFeatures().then(res => {
            mapSubFeatures(res)
        })

    }, [mapSubFeatures]);

    useEffect(() => {
        productsApi.getBrands().then(res => {
            setBrands(res)
        })

    }, []);

    return (
        <Modal open={props.isModalOpen} onClose={() => props.handleCloseModal()}>
            <Box component="form" onSubmit={saveProduct}>
                <Box
                    sx={{
                        position: "absolute",
                        top: "50%",
                        left: "50%",
                        transform: "translate(-50%, -50%)",
                        width: 700,
                        bgcolor: "background.paper",
                        boxShadow: 24,
                        p: 4,
                        borderRadius: 2,
                        maxHeight: "90vh",
                        overflowY: "auto",
                    }}
                >
                    <Typography variant="h6" gutterBottom>
                        {props.modalTitle}
                    </Typography>
                    <Box sx={{ display: "flex", gap: 2, marginBottom: 2 }}>
                        <TextField
                            label="Product Name"
                            name="name"
                            value={formData.name}
                            onChange={handleInputChange}
                            fullWidth
                            margin="normal"
                            error={!!errors.name}
                            helperText={errors.name}
                        />

                        <TextField
                            label="Stock"
                            name="stock"
                            value={formData.stock}
                            onChange={handleInputChange}
                            fullWidth
                            margin="normal"
                            type="number"
                            error={!!errors.stock}
                            helperText={errors.stock}
                        />

                    </Box>
                    <Box sx={{ display: "flex", gap: 2, marginBottom: 2 }}>
                        <TextField
                            label="Price"
                            name="price"
                            value={formData.price}
                            onChange={handleInputChange}
                            fullWidth
                            margin="normal"
                            type="number"
                            error={!!errors.price}
                            helperText={errors.price}
                        />

                        <TextField
                            label="SKU"
                            name="sku"
                            value={formData.sku}
                            onChange={handleInputChange}
                            fullWidth
                            margin="normal"
                            error={!!errors.sku}
                            helperText={errors.sku}
                        />

                    </Box>

                    <TextField
                        label="Product Description"
                        name="description"
                        fullWidth
                        multiline
                        rows={4}
                        value={formData.description}
                        onChange={handleInputChange}
                        sx={{ marginBottom: 2 }}
                        error={!!errors.description}
                        helperText={errors.description}

                    />

                    <Box sx={{ display: "flex", gap: 2, flexWrap: "wrap", marginBottom: 2 }}>

                        <Select
                            name="brandId"
                            value={formData.brandId}
                            onChange={handleSelectChange}
                            fullWidth
                            displayEmpty
                            error={!!errors.brandId}
                        >
                            <MenuItem value="" disabled>
                                Select Brand
                            </MenuItem>
                            {brands.map((brand) => (
                                <MenuItem key={brand.id} value={brand.id}>
                                    {brand.name}
                                </MenuItem>
                            ))}
                        </Select>
                        {errors.brandId && (
                            <span style={{ color: "red", fontSize: "0.8em" }}>{errors.brandId}</span>
                        )}
                        <Select
                            name="categoryId"
                            value={formData.categoryId}
                            onChange={handleSelectChange}
                            fullWidth
                            displayEmpty
                            error={!!errors.categoryId}
                        >
                            <MenuItem value="" disabled>
                                Select Category
                            </MenuItem>
                            {categories.map((category) => (
                                <MenuItem key={category.id} value={category.id}>
                                    {category.name}
                                </MenuItem>
                            ))}
                        </Select>
                        {errors.categoryId && (
                            <span style={{ color: "red", fontSize: "0.8em" }}>{errors.categoryId}</span>
                        )}
                        {categories && <Select
                            name="subCategoryId"
                            value={formData.subCategoryId}
                            onChange={handleSelectChange}
                            fullWidth
                            displayEmpty
                            error={!!errors.subCategoryId}
                        >
                            <MenuItem value="" disabled>
                                Select SubCategory
                            </MenuItem>
                            {subCategories && subCategories.map((subCategory) => (
                                <MenuItem key={subCategory.id} value={subCategory.id}>
                                    {subCategory.value}
                                </MenuItem>
                            ))}
                        </Select>
                        }
                        {errors.subCategoryId && (
                            <span style={{ color: "red", fontSize: "0.8em" }}>{errors.subCategoryId}</span>
                        )}
                    </Box>
                    <Box sx={{ display: "flex", flexWrap: "wrap", gap: 2 }}>
                        {mappedFeatures && mappedFeatures.map((feature) => (
                            <Box key={feature.id} sx={{ minWidth: "200px", flex: "1 0 auto" }}>
                                <Typography variant="subtitle1">{feature.name}</Typography>
                                <FormGroup>
                                    {feature.subFeatures && feature.subFeatures.map((subFeature) => (
                                        <FormControlLabel
                                            key={subFeature.id}
                                            control={
                                                <Checkbox
                                                    checked={subFeature.checked}
                                                    onChange={() => handleFeatureChange(feature.id, subFeature.id)}
                                                />
                                            }
                                            label={subFeature.value}
                                        />
                                    ))}
                                </FormGroup>
                            </Box>
                        ))}
                    </Box>
                    <Box sx={{ mt: 3, textAlign: "right" }}>
                        <Button variant="outlined" sx={{ mr: 1 }} onClick={() => props.handleCloseModal()}>
                            Cancel
                        </Button>
                        <Button variant="contained" onClick={() => saveProduct()}>
                            Save
                        </Button>
                    </Box>
                </Box>
            </Box>
        </Modal>
    )
}

export default AddEditProductModal;