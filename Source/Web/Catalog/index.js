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
}