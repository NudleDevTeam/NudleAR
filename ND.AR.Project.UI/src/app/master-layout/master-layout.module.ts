import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SideNavComponent } from './side-nav/side-nav.component';
import { ContentAreaComponent } from './content-area/content-area.component';
import { MasterLayoutComponent } from './master-layout.component';
import { MasterLayoutRoutingModule } from './master-layout.routing';




@NgModule({
  declarations: [
    SideNavComponent,
    ContentAreaComponent,
    MasterLayoutComponent
  ],
  imports: [
    CommonModule, MasterLayoutRoutingModule
  ]
})
export class MasterLayoutModule { }
