# Vcenter.Automation.OpenApi.Model.VcenterTaggingAssociationsIterationSpec
The Vcenter.Tagging.Associations.IterationSpec schema contains properties used to break results into pages when listing tags associated to objects see *GET /vcenter/tagging/associations*).  This schema was added in __vSphere API 7.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Marker** | **string** | Marker is an opaque token that allows the caller to request the next page of tag associations.  This property was added in __vSphere API 7.0.0.0__.  If missing or &#x60;null&#x60; or empty, first page of tag associations will be returned.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.tagging.associations.Marker&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.tagging.associations.Marker&#x60;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

