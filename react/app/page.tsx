'use client'
import Image from "next/image";
import HeaderStyle from "./styles/HeaderStyle.module.css";
import BodyStyle from "./styles/BodyStyle.module.css";
import Link from 'next/link';
import { NavBar } from "./components/NavBar";

export default function Home() {
  return (
    <main id="Home">
      <NavBar/>
      <h1 className={HeaderStyle.h1}>Welcome to Character Creator!</h1>
      <div className={BodyStyle.container}>
        <div id={BodyStyle.column}>
          <select required id="characters" name="characters">
            <option value="" selected disabled hidden>Select Character</option>
            <option value="Merlin">Merlin</option>
            <option value="Arthur">Arthur</option>
          </select>
          <ul>
            <li>Level: </li>
            <li>Exp: </li>
            <li>Class: </li>
            <li>HP: currentHP/maxHP</li>
            <li>AC: </li>
            <li>Gold: </li>
            <li>Str: </li>
            <li>Dex: </li>
            <li>Wis: </li>
            <li>Magic: </li>
            <li>Magic Resist: </li>
          </ul>
        </div>
        <div id={BodyStyle.column}>
          <header>Shop</header>
        </div>
      </div>
    </main>
  );
}