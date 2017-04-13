class GreaterThanTodayValidator < ActiveModel::EachValidator
  def validate_each(record, attribute, value)
    if value.present? and value > Date.today
      record.errors[attribute] << (options[:message] || 'La fecha no puede ser mayor a hoy')
    end
  end
end
