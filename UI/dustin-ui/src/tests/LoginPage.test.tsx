import { fireEvent, render, screen } from "@testing-library/react";
import LoginPage from "../auth/LoginPage";

describe("LoginPage", () => {

    it("renders login page with correct details", () => {
        render(<LoginPage />)
        const loginMessage = screen.getByTestId("message").textContent;
        expect(loginMessage).toEqual("Please log in to access your account and manage your products.")
    });

    // it("login button click", () => {
    //     render(<LoginPage />)
    //     const loginButton = screen.getByRole("button",{name:"Login"})
    //     fireEvent.click(loginButton)
    //     expect(loginMessage).toEqual("Please log in to access your account and manage your products.")
    // });


})