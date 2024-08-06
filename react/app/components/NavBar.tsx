import Head from "next/head";
import HeaderStyle from "../styles/HeaderStyle.module.css";

export const NavBar=()=>{
    return(
        <header id={HeaderStyle.header}>
            <h1>Welcome to Character Creator!</h1>
            <button>$ SHOP $</button>
        </header>
    )
}