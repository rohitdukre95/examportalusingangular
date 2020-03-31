
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class BaseService {

  myAppUrl: string;

  constructor(
    private httpClient: HttpClient,
    @Inject('BASE_URL') baseUrl: string
  ) {
    this.myAppUrl = baseUrl;
  }

  getRequest(url) {
    return this.httpClient.get(this.myAppUrl + url);
  }

  putRequest(url, data) {
    return this.httpClient.put(this.myAppUrl + url, data);
  }

  postRequest(url, data) {
    const httpHeaders = new HttpHeaders({
      'Content-Type': 'application/json',
      'Cache-Control': 'no-cache'
    });

    const options = {
      headers: httpHeaders
    };

    return this.httpClient.post(this.myAppUrl + url, data, options);
  }
  uploadFile(url, data) {
    const httpHeaders = new HttpHeaders({
      //'Content-Type': 'multipart/form-data',
      'Accept': 'application/json'
    });

    const options = {
      headers: httpHeaders
    };

    return this.httpClient.post(this.myAppUrl + url, data, options);
  }

  deleteRequest(url) {
    return this.httpClient.delete(this.myAppUrl + url);
  }
}
