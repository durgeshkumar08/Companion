import { NgModule } from '@angular/core';
import { Routes, RouterModule, Router, PreloadAllModules } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { CreateOrderWebComponent } from './create-order/create-order-web/create-order-web.component';
import { AppStateService } from './auth/app-state.service';


const WebRoutes: Routes = [
  { path: '', component: CreateOrderWebComponent },
  { path: '**', redirectTo: '' }
];

const TabletRoutes: Routes = [
  { path: '', component: CreateOrderWebComponent },
  { path: '**', redirectTo: '' }
];

const MobileRoutes: Routes = [
  { path: '', component: CreateOrderWebComponent },
  { path: '**', redirectTo: '' }
];

@NgModule({
  imports: [RouterModule.forRoot(WebRoutes, {preloadingStrategy: PreloadAllModules})],
  exports: [RouterModule]
})
export class AppRoutingModule {
  public constructor(private router: Router,
                     private appStateService: AppStateService) {
      if (appStateService.getIsMobileResolution()) {
        console.log('Setting routing for mobile device');
        router.resetConfig(MobileRoutes);
      } else if (appStateService.getIsTabletResolution()) {
        console.log('Setting routing for tablet device');
        router.resetConfig(TabletRoutes);
      } else {
        console.log('Setting routing for desktop device');
      }
    }
}
