import BodyStyle from "../styles/BodyStyle.module.css";
import React, { useState } from "react";
//import charString from "../layout"

/*
var charString = Window.onload = function(){(document.getElementById("charString") as HTMLImageElement)};
*/
const apiControls = require("../../apiControls.js");
async function getCharacters(){
    try{
      await apiControls.get(event, 'characters').then((response: any) => {
        console.log("getCharacters: ", response);
        //charString.textContent = JSON.stringify(response);
        return JSON.stringify(response);
      })
    }
    catch (err) {
    }
  }

const getCharacters2 = async () => {
    const response = await apiControls.get(event, 'characters')
    .then();
    return JSON.stringify(response);
}

export default async function CharacterSelect () {
    const charData = await getCharacters();
    return(
        <div id={BodyStyle.column}>
            <select required id="characters" name="characters">
                <option value="" selected disabled hidden>Select Character</option>
                <option value="Merlin">Merlin</option>
                <option value="Arthur">Arthur</option>
            </select>
            <p id="charString">TEST Character string: {}</p>
            <ul>
                <li>{charData}</li>
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
            <button>Delete Character</button>
        </div>
    )
}