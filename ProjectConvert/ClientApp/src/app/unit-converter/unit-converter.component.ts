import { Component } from '@angular/core';
import { NgForm, FormBuilder, FormGroup, Validators, FormControl } from '@angular/forms';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-unit-converter',
    templateUrl: './unit-converter.component.html',
    styleUrls: ['./unit-converter.component.scss']
})
export class UnitConverterComponent implements OnInit{

  coversionForm: FormGroup;
  constructor(private formBuilder: FormBuilder,  private router: Router) { }

  ngOnInit() {
    this.coversionForm = this.formBuilder.group({
      conversionvalue: ['', Validators.required],
      conversionfrom: ['', Validators.required],
      conversionto: ['',  Validators.required]
    });
  }


  onClickSubmit(data) {
    alert("Entered Email id : " + data);

    if (!this.coversionForm.valid) {
      return;
    }

    //if (this.title == "Create") {
    //  this._employeeService.saveEmployee(this.employeeForm.value)
    //    .subscribe((data) => {
    //      this._router.navigate(['/fetch-employee']);
    //    }, error => this.errorMessage = error)
    //}
    //else if (this.title == "Edit") {
    //  this._employeeService.updateEmployee(this.employeeForm.value)
    //    .subscribe((data) => {
    //      this._router.navigate(['/fetch-employee']);
    //    }, error => this.errorMessage = error)
    //}
  }

  cancel() {
    this.router.navigate(['/fetch-employee']);
  }
}
