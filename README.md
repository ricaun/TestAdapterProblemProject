# TestAdapterProblemProject

Sample project with 3 test projects with the same `NUnit` in `net48`.

## TestAdapterProblemProject

Project with the `NUnit` `TestAdapter`.

## TestProjectNoAdapter

Project with without `TestAdapter`.

## TestProjectRevitAdapter

Project with `RevitTest` `TestAdapter`.

## `Test Explorer` Problem

When build the solution, the `TestAdapter` trigger for all the projects.

![Image](https://github.com/user-attachments/assets/c3b28817-02f5-4c1e-9650-eccab960faab)

This duplicate the tests in the `Test Explorer` because the solution have two projects with two different `TestAdapter`.

The project without any `TestAdapter` is triggered as well and shows in the `Test Explorer`.

---