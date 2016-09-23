import * as ko from "knockout";
import {server} from "../Infrastructure/Server"

export class index
{
    constructor() {
        let self = this;

        this.products = ko.observableArray();
        
        server.get("/api/catalog/something",{}).then(result => {
            self.products(result);
        });
    }

    addToCart(item) {
        server.put("/api/cart", {sku: item.sku, quantity: 1});
    }
}