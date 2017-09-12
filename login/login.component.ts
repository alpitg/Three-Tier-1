import { Component, OnInit } from '@angular/core';
import { NgForm } from "@angular/forms";
import { DataService } from "../services/data.service";


@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
    [name: string]: any;


  //Login
  loginDetails: any;
  loading: false;
  public studentsLogin: Students[];

 constructor(private DataService: DataService) { }

  ngOnInit() {
  }



  //Login
  onLogin(fLogin: NgForm) {

    this.loginDetails = fLogin.value;
    console.log(this.loginDetails);

    //GET from api Student
    this.DataService.adminLogin(this.loginDetails).subscribe(
      (students) => {
        console.log(students);
        this.studentsLogin = students;
        var a=localStorage.setItem('currentUser', JSON.stringify(students));
        
        //this.router.navigate(['layout']);

      });

  }





}


//INTERFACES
interface Students {
  id: number,
  name: string,
  email: string,
  age: number
}

interface loginDetails {
  // username: string;
  // password: string;
  name: string;
  email: string;
}