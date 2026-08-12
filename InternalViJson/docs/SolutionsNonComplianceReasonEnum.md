# Vcenter.ViJson.OpenApi.Model.SolutionsNonComplianceReasonEnum
Describes possible reasons a solution is non compliant.  Possible values: - `WORKING`: There is ongoing work to achieve the desired state. - `ISSUE`: ESX Agent Manager has encountered am issue attempting to achieve the   desired state. - `IN_HOOK`: ESX Agent Manager is awaiting user input to continue attempting to   achieve the desired state. - `BLOCKED`: ESX Agent Manager is blocked from reaching the desired state.      For   example, this can occur if *SolutionsSequentialRemediationPolicy* is   set and another deployment is in #ISSUE state. - `OBSOLETE_SPEC`: An obsoleted spec is currently in application for this solution.      This state should take precedence over:   - *WORKING*   - *ISSUE*   - *IN_HOOK*   - *BLOCKED* - `NO_SPEC`: Application for this solution has never been requested with   *Solutions.Apply*. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

