export class Addition{  
    constructor(private x?: number, private y?: number){  
    }  
    Sum(){  
        console.log("SUM: " +(this.x + this.y));  
    }  
}  
export class Substraction{  
    constructor(private a?: number, private b?: number){  
    }  
    Substract(){  
        console.log("SUBSTRACTION: " +(this.a - this.b));  
    }  
}  

import  {Addition, Substraction} from './Modules';  
  
let addObject = new Addition(10, 20);   
let subObject = new Substraction(20, 10);  
  
addObject.Sum();  
subObject.Substract();  