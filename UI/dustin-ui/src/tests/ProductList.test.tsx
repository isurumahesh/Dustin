import React from "react";
import { render, screen} from "@testing-library/react";
import ProductList from "../components/products/ProductList";
import { ViewProductItemData } from "../types/productTypes";

describe("ProductList Component", () => {
    const mockProducts: ViewProductItemData[] = [
        {
            productId: "1",
            productItemId: "item1",
            name: "S25",
            description: "Description 1",
            brand: "Samsung",
            categoryName: "Category 1",
            categoryId: "categoryId",
            brandId: "brandId",
            subCategoryValue: "SubCategory 1",
            subCategoryId: "subCategoryId",
            sku: "SKU1",
            stock: "10",
            price: "100",
            selectedSubFeatures: [{ id: "f1", value: "Feature 1" }],
        },
        {
            productId: "2",
            productItemId: "item2",
            name: "MacBook",
            description: "MackBoook 15",
            brand: "Apple",
            categoryName: "Computers",
            categoryId: "categoryId",
            brandId: "brandId",
            subCategoryValue: "Laptops",
            subCategoryId: "subCategoryId",
            sku: "SKU2",
            stock: "20",
            price: "200",
            selectedSubFeatures: [{ id: "f2", value: "Feature 2" }],
        },
    ];

    const mockHandleEdit = jest.fn();
    const mockHandleDelete = jest.fn();

    it("renders the product table with the correct headers", () => {
        render(
            <ProductList
                products={mockProducts}
                handleEdit={mockHandleEdit}
                handleDelete={mockHandleDelete}
            />
        );

        expect(screen.getByText("Apple")).toBeInTheDocument();
        expect(screen.getByText("MacBook")).toBeInTheDocument();
        expect(screen.getByText("Description")).toBeInTheDocument();
        expect(screen.getByText("Computers")).toBeInTheDocument();
        expect(screen.getByText("Laptops")).toBeInTheDocument();
        expect(screen.getByText("Sku")).toBeInTheDocument();
        expect(screen.getByText("20")).toBeInTheDocument();
        expect(screen.getByText("200")).toBeInTheDocument();
        expect(screen.getByText("Features")).toBeInTheDocument();
    });

    it("renders the correct number of products", () => {
        render(
            <ProductList
                products={mockProducts}
                handleEdit={mockHandleEdit}
                handleDelete={mockHandleDelete}
            />
        );

        const rows = screen.getAllByRole("row");
        expect(rows).toHaveLength(mockProducts.length + 1);
    });

});
