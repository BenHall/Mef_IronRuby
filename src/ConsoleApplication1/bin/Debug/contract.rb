require 'ClassLibrary1'

class MyContract < PartDefinition

	include ClassLibrary1::IContract
	
	export ClassLibrary1::IContract
	
	def get_name
		"martin"	
	end

end