import {Data} from "./demo2";
class Department{
    department_id: number = 1;
    department_name: string = "IT";
    Department(did: number,dname: string){
        this.department_id = did;
        this.department_name = dname;
    }
}
class Student extends Department implements Data{  
    student_id: number;  
    student_name: string;
    student_city: string;  
    age: number;
    gender: string;
    constructor(id: number, name: string,city: string,dname: string,did: number,age: number,gender: string) {  
        super();
        this.student_id = id;
        this.student_name = name;
        this.student_city = city;     
        this.department_name = dname;
        this.department_id = did;
        this.gender = gender;
        this.age = age;
    }  
  
    display_data(): void{
        console.log("Student Id: "+this.student_id);
        console.log("Student Name: "+this.student_name);
        console.log("Student City:"+this.student_city);
        console.log("Dept Id:"+this.department_id);
        console.log("Dept Name:"+this.department_name);
        console.log("Age:"+this.age);
        console.log("Gender:"+this.gender);
    }   
}  

let s1 = new Student(101,"Parth Shah","Mumbai","IT",1,21,"Male");
let s2 = new Student(111,"Raj Parekh","Pune","CSE",2,22,"Male");

s1.display_data();
s2.display_data();

