"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
exports.__esModule = true;
var Department = /** @class */ (function () {
    function Department() {
        this.department_id = 1;
        this.department_name = "IT";
    }
    Department.prototype.Department = function (did, dname) {
        this.department_id = did;
        this.department_name = dname;
    };
    return Department;
}());
var Student = /** @class */ (function (_super) {
    __extends(Student, _super);
    function Student(id, name, city, dname, did, age, gender) {
        var _this = _super.call(this) || this;
        _this.student_id = id;
        _this.student_name = name;
        _this.student_city = city;
        _this.department_name = dname;
        _this.department_id = did;
        _this.gender = gender;
        _this.age = age;
        return _this;
    }
    Student.prototype.display_data = function () {
        console.log("Student Id: " + this.student_id);
        console.log("Student Name: " + this.student_name);
        console.log("Student City:" + this.student_city);
        console.log("Dept Id:" + this.department_id);
        console.log("Dept Name:" + this.department_name);
        console.log("Age:" + this.age);
        console.log("Gender:" + this.gender);
    };
    return Student;
}(Department));
var s1 = new Student(101, "Parth Shah", "Mumbai", "IT", 1, 21, "Male");
var s2 = new Student(111, "Raj Parekh", "Pune", "CSE", 2, 22, "Male");
s1.display_data();
s2.display_data();
