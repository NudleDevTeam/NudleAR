import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContentAreaComponent } from './content-area/content-area.component';
import { LoginComponent } from './user-management/login/login.component';
import { HomeComponent } from './home/home.component';
import { NotFoundComponent } from './user-management/not-found/not-found.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  {
    path: 'login',
    component: LoginComponent,
  },
  {
    path: 'content',
    component: ContentAreaComponent,
  },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent },
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
