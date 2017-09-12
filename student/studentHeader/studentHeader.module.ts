import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { StudentHeaderComponent } from "./studentHeader.component";
import { StudentHeaderRoutingModule } from "./studentHeader-routing.module";
import { ProfileComponent } from "../profile/profile.component";
import { AddStudentComponent } from "../add-student/add-student.component";

@NgModule({
    declarations: [
        StudentHeaderComponent,
        ProfileComponent,
        AddStudentComponent
    ],
    imports: [
        StudentHeaderRoutingModule
    ],
    providers: [],
    bootstrap: [StudentHeaderComponent]
})
export class StudentHeaderModule { }
