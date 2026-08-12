# Vcenter.Automation.OpenApi.Model.VcenterEnvironmentBrowserConfigTargetsGetParams
The Vcenter.EnvironmentBrowser.ConfigTargets.GetParams schema specifies the parameters for the *GET /vcenter/environment-browser/config-targets* operation, such as which clusters to query.  This schema was added in __vSphere API 8.0.2.00300__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Clusters** | **List&lt;string&gt;** | A set of Cluster IDs that specify for which Clusters the configuration target is requested.  This property was added in __vSphere API 8.0.2.00300__.  if missing or &#x60;null&#x60; or empty an error will be returned. Ability to pass unset value is left for future expansion.  When clients pass a value of this schema as a parameter, the property must contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. When operations return a value of this schema as a response, the property will contain identifiers for the resource type: &#x60;ClusterComputeResource&#x60;. | [optional] 
**Filter** | **List&lt;string&gt;** | Specify a filter to narrow the results.  Possible values:   - &#x60;DATASTORES&#x60;: Datastores category includes datastore list within a vim.vm.ConfigTarget.   - &#x60;NETWORKS&#x60;: Networks category includes network, opaqueNetwork, distributedVirtualPortgroup, distributedVirtualSwitch and legacyNetworkInfo within a vim.vm.ConfigTarget.   - &#x60;DEVICES&#x60;: Devices category includes cdRom, serial, parallel, sound, usb, floppy, scsiPassthrough, pciPassthrough, sriov, vFlashModule and sharedGpuPassthroughTypes within a vim.vm.ConfigTarget.   - &#x60;DISKS&#x60;: Disks category includes scsiDisk and ideDisk within a vim.vm.ConfigTarget.   For more information see: *Vcenter.EnvironmentBrowser.ConfigTargets.ConfigTargetSpec*.  This property was added in __vSphere API 8.0.2.00300__.  if missing or &#x60;null&#x60; or empty, all information for a given config target is returned. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

