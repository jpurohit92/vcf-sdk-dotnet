# Vcenter.Automation.OpenApi.Model.VcenterAuthorizationPrivilegeChecksIterationSpec
The Vcenter.Authorization.PrivilegeChecks.IterationSpec schema contains properties used to break results into pages when listing privilege checks, see *POST /vcenter/authorization/privilege-checks?action=list*).  This schema was added in __vSphere API 8.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | **long** | Specifies the maximum number of results to return.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60; defaults to default page size, which is controlled by config.vpxd.privilegeChecks.pageSize advanced option. | [optional] 
**Marker** | **string** | An opaque token which determines where the returned page should begin.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60; or empty, privilege checks will be returned from the first record. | [optional] 
**EndMarker** | **string** | An opaque token which determines where the returned page should end.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60; or empty, privilege checks will be returned up to size, if set, or up to the default page size. | [optional] 
**TimeoutMs** | **long** | Indicates how long the request should wait in ms for a matching check if *Vcenter.Authorization.PrivilegeChecks.IterationSpec.marker* is set, and there no matching checks to be added to the result.  This property was added in __vSphere API 8.0.0.0__.  If missing or &#x60;null&#x60; or empty, the request will not wait for additional privilege checks and will return immediately. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

