import Image from "next/image";
import {NavBar} from "./components/NavBar";
import {ColumnLeft} from "./components/ColumnLeft";
import {ColumnRight} from "./components/ColumnRight";
import BodyStyle from "./styles/BodyStyle.module.css";

export default function Home() {
  return (
    <main id="main">
      <NavBar></NavBar>
      <div className={BodyStyle.container}>
        <ColumnLeft></ColumnLeft>
        <ColumnRight></ColumnRight>
      </div>
    </main>
  );
}