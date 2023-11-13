import { ProductService } from './ProductService';
let _productService = new ProductService();

let result;

result = _productService.getProducts();

console.log(result);