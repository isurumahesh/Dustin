import axios from "axios";
import { appSettings } from "../appSettings";
import { Brand, Category, CreateProduct, Feature, Product, UpdateProduct } from "../types/productTypes";
import axiosInstance from "./axiosInstance";


export const productsApi = {
    getCategories(): Promise<Category[]> {
        return axiosInstance.get<Category[]>(`/categories`).then(res => {
            return res.data
        }).catch(err =>
            Promise.reject(err)
        );
    },

    getFeatures(): Promise<Feature[]> {
        console.log(appSettings.DustinApiUrl)
        return axiosInstance.get<Feature[]>(`/features`).then(res => {
            return res.data
        }).catch(err =>
            Promise.reject(err)
        );
    },

    getBrands(): Promise<Brand[]> {
        console.log(appSettings.DustinApiUrl)
        return axiosInstance.get<Brand[]>(`/brands`).then(res => {
            return res.data
        }).catch(err =>
            Promise.reject(err)
        );
    },

    getProducts(): Promise<Product[]> {
        return axiosInstance.get<Product[]>(`/products`).then(res => {
            return res.data
        }).catch(err =>
            Promise.reject(err)
        );
    },

    saveProduct(product: CreateProduct) {
        return axiosInstance.post(`/products`, product).then(res => {
            return res.data
        }).catch(err =>
            Promise.reject(err)
        );
    },

    updateProduct(product: UpdateProduct) {
        return axiosInstance.put(`/products/${product.id}`, product).then(res => {
            return res
        }).catch(err =>
            Promise.reject(err)
        );
    },

    deleteProduct(id: string) {
        return axiosInstance.delete(`/products/${id}`).then(res => {
            return res
        }).catch(err =>
            Promise.reject(err)
        );
    },

    getProduct(id: string) {
        return axiosInstance.get<Product>(`/products/${id}`).then(res => {
            return res.data
        }).catch(err =>
            Promise.reject(err)
        );
    },

}