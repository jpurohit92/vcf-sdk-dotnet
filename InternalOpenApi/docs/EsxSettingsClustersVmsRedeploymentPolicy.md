# Vcenter.Automation.OpenApi.Model.EsxSettingsClustersVmsRedeploymentPolicy
The Esx.Settings.Clusters.Vms.RedeploymentPolicy enumerated type defines the different remediation policies which require redeployment of the System VMs.  Possible values:   - `RECREATE`: The default policy used by vLCM for System VM redeployment. System VMs are redeployed as follows: Once the new replica is provisioned, the old replica is powered off and deleted. Then the new replica is powered on and it's setup is completed to have the System VM fully operational.    This policy causes a downtime.    - `BLUE_GREEN`: Follows a standard blue-green strategy. System VMs are redeployed as follows: Once the new replica is provisioned, it is powered on. Then the new replica setup is completed to have the System VM fully operational. Then the old replica is powered off and deleted.    This policy provides zero-downtime.    This enumeration was added in __vSphere API 9.1.0.0__.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

