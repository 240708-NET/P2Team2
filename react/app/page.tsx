import Image from "next/image";
import {NavBar} from "./components/NavBar";
import BodyStyle from "./styles/BodyStyle.module.css";

export default function Home() {
  return (
    <main id="main">
      <NavBar></NavBar>
      <div className={BodyStyle.container}>
        <div id={BodyStyle.column}>
          <p>This is the left column</p>
        </div>
        <div id={BodyStyle.column}>
          <p>This is the right column</p>
          <p>Options:</p>
          <ul id={BodyStyle.ul}>
              <li><button>create character</button></li>
              <li><button>shop</button></li>
          </ul>
        </div>
      </div>
    </main>
  );
}