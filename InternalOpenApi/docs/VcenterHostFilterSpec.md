# Vcenter.Automation.OpenApi.Model.VcenterHostFilterSpec
The Vcenter.Host.FilterSpec schema contains properties used to filter the results when listing hosts (see *GET /vcenter/host*). If multiple properties are specified, only hosts matching all of the properties match the filter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Standalone** | **bool** | If true, only hosts that are not part of a cluster can match the filter, and if false, only hosts that are are part of a cluster can match the filter.  If missing or &#x60;null&#x60; Hosts can match filter independent of whether they are part of a cluster or not. If this field is true and *Vcenter.Host.FilterSpec.clusters* is not empty, no hosts will match the filter. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

