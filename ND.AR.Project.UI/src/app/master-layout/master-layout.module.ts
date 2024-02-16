import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SideNavComponent } from './side-nav/side-nav.component';
import { MasterLayoutComponent } from './master-layout.component';
import { MasterLayoutRoutingModule } from './master-layout.routing';




@NgModule({
  declarations: [
    SideNavComponent,
    MasterLayoutComponent
  ],
  imports: [
    CommonModule, MasterLayoutRoutingModule
  ]
})
export class MasterLayoutModule { }
