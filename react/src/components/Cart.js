import React, { Fragment, useState, useEffect } from "react";
import { Button, Card, ListGroup } from "react-bootstrap";
import { Link } from "react-router-dom";
import axios from "axios";


function Cart() {
  const [data, setData] = useState([]);

  useEffect(() => {
    axios
      .get("https://localhost:44373/api/Shop/ProductListCart")
      .then((result) => {
        setData(result.data.listproducts);
        console.log(result.data.listproducts);
      })
      .catch((error) => {
        alert(error.message);
      });
  }, []);

     const handleDltproduct = (id) => {
       const data = {
         Id: id,
      };
       axios
          .post("https://localhost:44373/api/Shop/AddProduct", data)
         .then((result) => {
          if (result.data.statusCode === "200") {
           alert("item added to Cart");
         } else {
             alert("no item added");
          }
         })
         .catch((error) => {
           console.log(error);
         });
     };

  return (
    <div className="container mt-3">
      <div className="row d-flex justify-content-center align-items-center">
        {data && data.length > 0
          ? data.map((item, index) => {
              return (
                <>
                  <Card
                    style={{ width: "22rem", border: "none" }}
                    className="mx-2 mt-4 card_style"
                  >
                    <Card.Img
                      variant="top"
                      src={`assets/images/${item.image}` }
                      style={{ height: "16rem" }}
                    />
                    <Card.Body>
                      <Card.Text>{item.id}</Card.Text>
                      <Card.Text>{item.name}</Card.Text>
                    </Card.Body>
                    <ListGroup className="list-group-flush">
                      <ListGroup.Item>
                        <h6>price:</h6>
                        <p>{item.actualPrice}</p>
                        <h6>premium price:</h6>
                        <p>{item.discountedPrice}</p>
                      </ListGroup.Item>
                    </ListGroup>
                    {/* <Card.Body>
                      <div className="button_div d-flex justify-content-right">
                        <Button
                          variant="primary"
                          onClick={handleDltproduct(item.id)}
                        >
                          Delete Item
                        </Button>
                      </div>
                    </Card.Body> */}
                  </Card>
                </>
              );
            })
          : "No data"}
      </div>
    </div>
  );
}
export default Cart;