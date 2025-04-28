import { CreateProduct, Product, SelectedSubFeatures, UpdateProduct, ViewProductItemData } from "../types/productTypes";

export const getAllProductItems = (products: Product[]) => {

    let productItems: ViewProductItemData[] = [];
    products.forEach(product => {

        let items = getProductItems(product);
        productItems = [...productItems, ...items];
    })

    return productItems;
}


export const getProductItems = (product: Product) => {

    const productItems: ViewProductItemData[] = [];

    product.productItems?.forEach(item => {

        let productItem: ViewProductItemData = {
            productItemId: item.id,
            productId: product.id,
            name: product.name,
            description: product.description,
            price: item.price.toString(),
            sku: item.sku,
            brandId: product.brand?.id ?? "",
            brand: product.brand?.name ?? "",
            stock: item.stock.toString(),
            categoryName: product.subCategory?.category?.name ?? "",
            categoryId: product.subCategory?.category?.id ?? "",
            subCategoryId: product.subCategory?.id ?? "",
            subCategoryValue: product.subCategory?.value ?? "",
            selectedSubFeatures: item.productItemSubFeatures && item.productItemSubFeatures.map((subFeature) => ({
                id: subFeature?.subFeature?.id,
                value: subFeature?.subFeature?.value,

            })),
        }
        productItems.push(productItem)

    })

    return productItems;
}

export const initializeProductFormData = () => {
    return {
        name: "",
        productId: "",
        productItemId: "",
        subCategoryValue: "",
        description: "",
        price: "",
        sku: "",
        brandId: "",
        brand: "",
        stock: "",
        categoryName: "",
        categoryId: "",
        subCategoryId: "",
        selectedSubFeatures: [],
    }
}

export const mapCreateProduct = (formData: ViewProductItemData, selectedSubfeatures: SelectedSubFeatures[]) => {
    const createProduct: CreateProduct = {
        name: formData.name,
        description: formData.description,
        brandId: formData.brandId,
        subCategoryId: formData.subCategoryId,
        productItems: [{ stock: formData.stock, price: formData.price, sku: formData.sku, subFeatures: selectedSubfeatures }]

    }
    return createProduct;
}

export const mapUpdateProduct = (formData: ViewProductItemData, selectedSubfeatures: SelectedSubFeatures[]) => {
    const updateProduct: UpdateProduct = {
        id: formData.productId,
        name: formData.name,
        description: formData.description,
        brandId: formData.brandId,
        subCategoryId: formData.subCategoryId,
        productItems: [{ id: formData.productItemId, stock: formData.stock, price: formData.price, sku: formData.sku, subFeatures: selectedSubfeatures }]

    }

    return updateProduct;
}
