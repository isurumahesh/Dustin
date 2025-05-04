import React from "react";
import Layout from "./layout/Layout";
import ProductList from "./products/ProductList";
import ProductsPage from "./products/ProductsPage";


const HomePage: React.FC = () => {
  return (
    <Layout>
      <ProductsPage />
    </Layout>
  );
};

export default HomePage;
