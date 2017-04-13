json.extract! person, :id, :name, :last_name, :mother_name, :age, :birthday, :email, :phone, :created_at, :updated_at
json.url person_url(person, format: :json)
