export type BaseEntity = {
    id: string; 
};

export type Brand = BaseEntity & {
    name: string;
};

export type Category = BaseEntity & {
    name: string;
    subCategories?: SubCategory[]; 
};

export type SubCategory = BaseEntity & {
    value: string;
    categoryId: string;
    category?: Category; 
};

export type Feature = BaseEntity & {
    name: string;
    subFeatures?: SubFeature[]; 
};

export type SubFeature = BaseEntity & {
    value: string;
    featureId: string;
    feature?: Feature; 
    checked: boolean;
    productItemSubFeatures?: ProductItemSubFeature[]; 
};

export type Product = BaseEntity & {
    name: string;
    description: string;
    subCategoryId: string;
    category: Category;
    subCategory?: SubCategory;
    brandId: string;
    brand?: Brand; 
    productItems?: ProductItem[]; 
};

export type ProductItem = BaseEntity & {
    sku: string;
    stock: number;
    price: number;
    productId: string;
    product?: Product; 
    productItemSubFeatures?: ProductItemSubFeature[]; 
};

export type ProductItemSubFeature = {
    subFeatureId: string;
    subFeature?: SubFeature; 
    productItemId: string;
    productItem?: ProductItem; 
};

export type SelectedSubFeatures = {
    id: string | undefined
    value: string | undefined
}

export type AddProductFormData = {
    name: string;
    description: string;
    price: string;
    sku: string;
    brandId: string;
    stock: string;
    category: string;
    subCategoryId: string;
    selectedSubFeatures: SelectedSubFeatures[];
}

export type UpdateProduct = {
    id: string;
    name: string;
    description: string;
    brandId: string;
    subCategoryId: string;
    productItems: UpdateProductItem[]

}

export type CreateProduct = {
    name: string;
    description: string;
    brandId: string;
    subCategoryId: string;
    productItems: CreateProductItem[]
}

export type UpdateProductItem = {
    id: string
    price: string;
    sku: string;
    stock: string;
    subFeatures: SelectedSubFeatures[];
}

export type CreateProductItem = Omit<UpdateProductItem, "id">;

export type ViewProductItemData = {
    productItemId: string;
    productId: string;
    name: string;
    description: string;
    price: string;
    sku: string;
    brandId: string;
    brand: string;
    stock: string;
    categoryId: string;
    categoryName: string;
    subCategoryValue: string;
    subCategoryId: string;
    selectedSubFeatures: SelectedSubFeatures[] | undefined;
}


