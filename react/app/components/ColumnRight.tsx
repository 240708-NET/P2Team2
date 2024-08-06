import BodyStyle from "../styles/BodyStyle.module.css";

export const ColumnRight=()=>{
    return(
        <div id={BodyStyle.column}>
                <p>This is the right column</p>
                <p>Options:</p>
                <ul id={BodyStyle.ul}>
                    <li><button>create character</button></li>
                    <li><button>shop</button></li>
                </ul>
        </div>
    )
}