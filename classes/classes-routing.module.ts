import { NgModule } from "@angular/core";
import { Router, Route, Routes, RouterModule } from "@angular/router";
import { ClassesComponent } from "./classes.component";
import { ClassesHeaderComponent } from "./classesHeader/classesHeader.component";

const routes: Routes = [
    {
        path: '', 
        component: ClassesComponent,
         children: [
            { path: '', component: ClassesHeaderComponent },
            { path: 'classesHeader', component: ClassesHeaderComponent },
           // { path: '', component: StudentHeaderComponent }
        ]
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ClassesRoutingModule {

}