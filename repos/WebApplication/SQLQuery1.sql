alter table employee with check add constraint fk_emp_dept foreign key (departmentid)
references department(id)

alter table employee check constraint fk_emp_dept 