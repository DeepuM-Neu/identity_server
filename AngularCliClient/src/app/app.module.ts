import { NgModule, APP_INITIALIZER } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { routing } from './app.routes';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { DataEventRecordsModule } from './dataeventrecords/dataeventrecords.module';
import { ForbiddenComponent } from './forbidden/forbidden.component';
import { HomeComponent } from './home/home.component';
import { UnauthorizedComponent } from './unauthorized/unauthorized.component';
import { AuthModule, OidcConfigService, LogLevel } from 'angular-auth-oidc-client';

export function configureAuth(oidcConfigService: OidcConfigService): any {
  return () =>
      oidcConfigService.withConfig({
        stsServer: 'https://dev-apmf-federation-gateway.australiaeast.cloudapp.azure.com',
        redirectUrl: 'http://localhost:4200/',
        postLogoutRedirectUri: 'http://localhost:4200/',
        clientId: 'PicklesOidcCompatible-local',
          scope: 'openid profile email',
          responseType: 'code',
          // silentRenew: true,
          renewTimeBeforeTokenExpiresInSeconds: 10,
          useRefreshToken: true,
          logLevel: LogLevel.Debug,
      });
}

@NgModule({
  imports: [
      BrowserModule,
      FormsModule,
      routing,
      HttpClientModule,
      DataEventRecordsModule,
      AuthModule.forRoot(),
  ],
  declarations: [
      AppComponent,
      ForbiddenComponent,
      HomeComponent,
      UnauthorizedComponent
  ],
  providers: [
      OidcConfigService,
      {
          provide: APP_INITIALIZER,
          useFactory: configureAuth,
          deps: [OidcConfigService, HttpClient],
          multi: true,
      }
  ],
  bootstrap: [AppComponent],
})

export class AppModule {
  constructor() {
      console.log('APP STARTING');
  }
}
