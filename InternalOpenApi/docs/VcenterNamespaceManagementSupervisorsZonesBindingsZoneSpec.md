# Vcenter.Automation.OpenApi.Model.VcenterNamespaceManagementSupervisorsZonesBindingsZoneSpec
The Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.ZoneSpec schema contains the input parameters for creating the bindings between the vSphere Zone and a Supervisor.  This schema was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Zone** | **string** | Identifiers of the vSphere Zone to bind with the Supervisor.  This property was added in __vSphere API 9.0.0.0__.  When clients pass a value of this schema as a parameter, the property must be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. When operations return a value of this schema as a response, the property will be an identifier for the resource type: &#x60;com.vmware.vcenter.consumption_domains.Zone&#x60;. | 
**Type** | **string** | Type of the vSphere Zone.  Possible values:   - &#x60;MANAGEMENT&#x60;: The vSphere Zone is a zone which contains control plane components and workloads.   - &#x60;WORKLOAD&#x60;: The vSphere Zone is a zone which only contains workloads.   For more information see: *Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.Type*.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, the type of the vSphere Zone is default to *Vcenter.NamespaceManagement.Supervisors.Zones.Bindings.Type.WORKLOAD*. | [optional] 
**ResourceAllocation** | [**VcenterNamespaceManagementSupervisorsZonesBindingsResourceAllocationSpec**](VcenterNamespaceManagementSupervisorsZonesBindingsResourceAllocationSpec.md) | Resource allocation to be configured on the vSphere Zone.  This property was added in __vSphere API 9.0.0.0__.  If missing or &#x60;null&#x60;, no resources will be allocated to the Supervisor in this vSphere Zone. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

