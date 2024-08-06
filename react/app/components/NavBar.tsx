import Head from "next/head";
import HeaderStyle from "../styles/HeaderStyle.module.css";

export const NavBar=()=>{
    return(
        <header id={HeaderStyle.header}>
            <h1>Character Creator</h1>
            <button className={HeaderStyle.button}>Display Characters</button>
            <button className={HeaderStyle.button}>Create New Character</button>
            <button className={HeaderStyle.shopButton}>$ SHOP $</button>
        </header>
    )
}