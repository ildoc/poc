import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpHeaders, HttpHeaderResponse } from '@angular/common/http';
import { map, catchError } from 'rxjs/operators';
import { of } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  response1: string;
  response2: string;

  private serverAddr = 'http://localhost:5000';
  private httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/text',
    })
  };

  constructor(private http: HttpClient) { }

  async ngOnInit() {
    this.http.get(`${this.serverAddr}/api/service1/Test1`, this.httpOptions).subscribe(x => this.response1 = x as string);
    this.http.get(`${this.serverAddr}/api/service2/Test2`, this.httpOptions).subscribe(x => this.response2 = x as string);
  }
}
