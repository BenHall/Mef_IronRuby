require 'ClassLibrary1'

class MyContract2 < PartDefinition

	include ClassLibrary1::IContract
	
	export ClassLibrary1::IContract
	
	def get_name
		"bob"	
	end

end