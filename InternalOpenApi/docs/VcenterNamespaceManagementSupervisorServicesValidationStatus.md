# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorServicesValidationStatus
The Vcenter.NamespaceManagement.SupervisorServices.ValidationStatus enumerated type defines the type of status for validating content of a Supervisor Service version.  Possible values:   - `VALID`: Indicates the content is valid for a Supervisor Service version.   - `VALID_WITH_WARNINGS`: Indicates the content is valid for a Supervisor Service version, but the content may contain information that should be reviewed closely and could prevent the Supervisor Service version to be created successfully later, which is explained in warning_messages. For example, the content may specify a Supervisor Service version that already exists on this vCenter.   - `INVALID`: Indicates the content is invalid for a Supervisor Service version, in which case the reasons can be found in error_messages.   This enumeration was added in __vSphere API 7.0.3.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

