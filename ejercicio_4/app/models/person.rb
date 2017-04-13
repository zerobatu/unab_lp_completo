class Person < ActiveRecord::Base
  validates :name, presence: { message: 'debe estar presente'}
  validates :last_name, presence: { message: 'debe estar presente' }
  validates :mother_name, presence: { message: 'debe estar presente' }
  validates :age, presence: { message: 'debe estar presente' }
  validates :birthday, presence: { message: 'debe estar presente' }, greater_than_today: true
  # greater_than_today este metodo valida la fecha esta se puede ver en la carpeta app/validators/greater_than_today_validator.rb
  validates :email, presence: { message: 'debe estar presente' }, email: true
  # email: true permite validar el formato del correo este codigo esta en app/validar/email_validator.rb
  #validates :phone, presence: { message: 'debe estar presente' }
  validates :phone, format: { with: /\+[0-9]{11}/, message: "formato invalido." }, allow_blank: true
end
