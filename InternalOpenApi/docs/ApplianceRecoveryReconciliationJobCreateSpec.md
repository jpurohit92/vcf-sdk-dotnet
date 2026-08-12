# Vcenter.Automation.OpenApi.Model.ApplianceRecoveryReconciliationJobCreateSpec
The Appliance.Recovery.Reconciliation.Job.CreateSpec schema has the fields to request the start of reconciliation job.  This schema was added in __vSphere API 6.7__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SsoAdminUserName** | **string** | Administrators username for SSO.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; SSO authentication will not be used. If the vCenter Server is a management node or an embedded node, authentication is required. | [optional] 
**SsoAdminUserPassword** | **string** | Password for SSO admin user.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60; SSO authentication will not be used. If the vCenter Server is a management node or an embedded node, authentication is required. | [optional] 
**IgnoreWarnings** | **bool** | Flag indicating whether warnings should be ignored during reconciliation.  This property was added in __vSphere API 6.7__.  If missing or &#x60;null&#x60;, validation warnings will fail the reconciliation operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

