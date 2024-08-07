'use client'

//import Head from "next/head";
import CharacterDisplay from '../pages/CharacterDisplay';
import CharacterForm from '../pages/CharacterForm';
import Home from '../page';
import HeaderStyle from "../styles/HeaderStyle.module.css";

export const NavBar = () => {
    return(
            <nav id={HeaderStyle.header}>
                <h1>Character Creator</h1>
                <button className={HeaderStyle.navButton}>Display Characters</button>
                <button className={HeaderStyle.navButton}>Create New Character</button>
                <button className={HeaderStyle.shopButton}>$ SHOP $</button>
            </nav>
    )
}