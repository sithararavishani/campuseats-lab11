import { Link } from "react-router-dom";
import DishCard from "./DishCard";

function MenuList({ dishes }) {
  if (!dishes.length) return <p>No dishes match your search.</p>;
  return (
    <div className="menu-grid">
      {dishes.map((dish) => (
        <Link key={dish.id} to={`/dish/${dish.id}`} style={{ textDecoration: "none", color: "inherit" }}>
          <DishCard dish={dish} />
        </Link>
      ))}
    </div>
  );
}

export default MenuList;