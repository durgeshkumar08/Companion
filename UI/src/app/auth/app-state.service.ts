import {Injectable} from '@angular/core';

@Injectable()
export class AppStateService {

  MOBILE_WIDTH_MAX = 425;
  TABLET_WIDTH_MAX = 1024;
  private isMobileResolution: boolean;
  private isTabletResolution: boolean;

  constructor() {
    console.log('Window width is ' + window.innerWidth);
    if (window.innerWidth <= this.MOBILE_WIDTH_MAX) {
      console.log('Setting for mobile view');
      this.isMobileResolution = true;
      this.isTabletResolution = false;
    } else if (window.innerWidth > this.MOBILE_WIDTH_MAX && window.innerWidth <= this.TABLET_WIDTH_MAX) {
      console.log('Setting for tablet view');
      this.isMobileResolution = false;
      this.isTabletResolution = true;
    } else {
      console.log('Setting for desktop view');
      this.isMobileResolution = false;
      this.isTabletResolution = false;
    }
  }

  public getIsMobileResolution(): boolean {
    return this.isMobileResolution;
  }

  public getIsTabletResolution(): boolean {
    return this.isTabletResolution;
  }
}
