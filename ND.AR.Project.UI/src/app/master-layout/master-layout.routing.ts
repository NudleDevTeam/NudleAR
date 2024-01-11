
import { MasterLayoutComponent } from './master-layout.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContentAreaComponent } from './content-area/content-area.component';

const routes: Routes = [
  {
    path: '',
    component: MasterLayoutComponent,
    children: [
      {
        path: 'content',
        component: ContentAreaComponent,
      },
    //   {
    //     path: 'user-management',
    //     component: UserManagementComponent,
    //     canActivate: [AdminGuard],
    //   },
    //   {
    //     path: 'leave-management',
    //     component: LeaveManagementComponent,
    //   },
    //   {
    //     path: 'ikm-management',
    //     component: IkmManagementComponent,
    //   },
      
    ],
  },
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [
    RouterModule,
  
  ],
})
export class MasterLayoutRoutingModule {
  static components = [MasterLayoutComponent]
}
