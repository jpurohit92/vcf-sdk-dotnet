# Vcenter.Automation.OpenApi.Model.VcenterOvfIpAllocationParamsIpAllocationPolicy
The Vcenter.Ovf.IpAllocationParams.IpAllocationPolicy enumerated type defines the possible IP allocation policy for a deployment.  Possible values:   - `DHCP`: Specifies that DHCP will be used to allocate IP addresses.   - `TRANSIENT_IPPOOL`: Specifies that IP addresses are allocated from an IP pool. The IP addresses are allocated when needed, typically at power-on, and deallocated during power-off. There is no guarantee that a property will receive same IP address when restarted.   - `STATIC_MANUAL`: Specifies that IP addresses are configured manually upon deployment, and will be kept until reconfigured or the virtual appliance destroyed. This ensures that a property gets a consistent IP for its lifetime.   - `STATIC_IPPOOL`: Specifies that IP addresses are allocated from the range managed by an IP pool. The IP addresses are allocated at first power-on, and remain allocated at power-off. This ensures that a virtual appliance gets a consistent IP for its life-time. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

