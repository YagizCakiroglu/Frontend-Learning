export class Product {
    id: number;
    name: string;

    constructor(
        public id?: number,
        public name?: string,
        public category?: string,
        public price?: number
    ) {}
}

