import { Component, Inject } from '@angular/core';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';

@Component({
    selector: 'app-unit-converter',
    templateUrl: './unit-converter.component.html',
    styleUrls: ['./unit-converter.component.scss']
})
export class UnitConverterComponent {

  coversionForm: FormGroup;
  OutputValue;
  httpclient: HttpClient;
  baseUrl: string;
  constructor(private formBuilder: FormBuilder, private router: Router, http: HttpClient, @Inject('BASE_URL')  baseUrl: string) {
    this.coversionForm = this.formBuilder.group({
      conversionvalue: ['', Validators.required],
      conversionfrom: ['kg', Validators.required],
      conversionto: ['lbs', Validators.required]
    });
    this.httpclient = http;
    this.baseUrl = baseUrl;
  }

  

  onClickSubmit() {

    if (!this.coversionForm.valid) {
      return;
    }

    this.httpclient.get<string[]>(this.baseUrl + 'api/mass/' + this.coversionForm.controls['conversionvalue'].value + '/' + this.coversionForm.controls['conversionfrom'].value + '/' + this.coversionForm.controls['conversionto'].value).subscribe(result => {
      this.OutputValue = result[0]+" = "+result[1];
    }, error => console.error(error));

 
  }

  cancel() {
    this.router.navigate(['/unit-converter']);
  }
}
