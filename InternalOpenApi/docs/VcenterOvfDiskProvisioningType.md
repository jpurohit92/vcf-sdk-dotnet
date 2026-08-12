# Vcenter.Automation.OpenApi.Model.VcenterOvfDiskProvisioningType
The Vcenter.Ovf.DiskProvisioningType enumerated type defines the virtual disk provisioning types that can be set for a disk on the target platform.  Possible values:   - `thin`: A thin provisioned virtual disk has space allocated and zeroed on demand as the space is used.   - `thick`: A thick provisioned virtual disk has all space allocated at creation time and the space is zeroed on demand as the space is used.   - `eagerZeroedThick`: An eager zeroed thick provisioned virtual disk has all space allocated and wiped clean of any previous contents on the physical media at creation time.    Disks specified as eager zeroed thick may take longer time to create than disks specified with the other disk provisioning types. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

