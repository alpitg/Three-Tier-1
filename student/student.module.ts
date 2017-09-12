import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { StudentComponent } from "./student.component";
import { StudentRoutingModule } from "./student-routing.module";
import { StudentHeaderComponent } from "./studentHeader/studentHeader.component";
import { ProfileComponent } from "./profile/profile.component";

@NgModule({
    declarations: [
       StudentComponent
    ],
    imports: [
        StudentRoutingModule
    ],
    providers: [],
    bootstrap: [StudentComponent]
})
export class StudentModule { }
