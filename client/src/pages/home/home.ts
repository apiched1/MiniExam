import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Students } from '../../app/models';


@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  public students: Students = new Students();
  public student: Students[];

  constructor(public navCtrl: NavController, private http: HttpClient) {

  }
  onClick() {
    this.http.get<Students[]>("https://localhost:5001/api/Values/GetAllStudents")
      .subscribe(
        data => {
          this.student = data;
          console.log(data);
        }
      );
  }

  subMit() {
    this.http.get("https://localhost:5001/api/Values/AddStudent/" + this.students.name)
      .subscribe(
        data => {
        }
      );
  }

}
