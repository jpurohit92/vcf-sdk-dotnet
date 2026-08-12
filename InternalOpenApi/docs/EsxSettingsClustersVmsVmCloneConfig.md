# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsVmCloneConfig
The Esx.Settings.Clusters.Vms.VmCloneConfig enumerated type defines the different configurations for VM cloning.  Possible values:   - `ALL_CLONES`: The system creates a snapshot of the first deployed VM and after that uses one of the available VM clone methods to deploy others.   - `FULL_CLONES_ONLY`: The system creates a snapshot of the first deployed VM and after that uses full VM clone method to deploy others.   - `NO_CLONES`: The system does not use VM clone methods to deploy VMs.   This enumeration was added in __vSphere API 9.0.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

