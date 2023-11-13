import { Product } from "./product";

export class SimpleDataSource {
    private products: Array<Product>;

    constructor() {
        this.products = new Array<Product>(
            new Product(1,"İphone 15 Pro Max", "Telefon", 100000),
            new Product(2,"İphone 15 Pro", "Telefon", 90000),
            new Product(3,"İphone 15", "Telefon", 80000),
            new Product(4,"İphone 15 Mini", "Telefon", 70000),
        );
    }

    getProducs(): Product[] {
        return this.products;
    }
}
